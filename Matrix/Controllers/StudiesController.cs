using AutoMapper;
using Matrix.Services;
using Matrix.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Matrix.Entities;
using Microsoft.AspNetCore.JsonPatch;

namespace Matrix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudiesController : ControllerBase
    {
        private readonly ISkillMatrixRepository _skillMatrixRepository;
        private readonly IMapper _mapper;

        public StudiesController(ISkillMatrixRepository skillMatrixRepository, IMapper mapper)
        {
            _skillMatrixRepository = skillMatrixRepository ??
               throw new ArgumentNullException(nameof(skillMatrixRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet("getStudyByEmployee/{employeeId}", Name = "GetStudyByEmployee")]
        public ActionResult<IEnumerable<StudyDto>> GetStudyForEmployee(Guid employeeId)
        {
            if(!_skillMatrixRepository.EmployeeExists(employeeId))
            {
                return NotFound();
            }
            var studiesForEmployeeFromRepo = _skillMatrixRepository.GetStudies(employeeId);
            return Ok(_mapper.Map<IEnumerable<StudyDto>>(studiesForEmployeeFromRepo));

        }

        [HttpGet("getAllStudies")]
        public IActionResult GetStudies()
        {
            var studiesFromRepo = _skillMatrixRepository.GetAllStudies();
            return Ok(studiesFromRepo);
        }

        [HttpGet("{employeeId}/{studyId}", Name = "GetStudyForEmployee")]
        public ActionResult<StudyDto> GetStudyForEmployee(Guid employeeId, Guid studyId)
        {
            if (!_skillMatrixRepository.EmployeeExists(employeeId))
            {
                return NotFound();
            }

            var studyForEmployeeFromRepo = _skillMatrixRepository.GetStudy(employeeId, studyId);

            if (studyForEmployeeFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<StudyDto>(studyForEmployeeFromRepo));
        }

        [HttpPost("{employeeId}")]
        public ActionResult<StudyDto> CreateStudyForEmployee(Guid employeeId, StudyForCreationDto study)
        {
            if(!_skillMatrixRepository.EmployeeExists(employeeId))
            {
                return NotFound();
            }
            var studyEntity = _mapper.Map<Entities.Study>(study);
            _skillMatrixRepository.AddStudy(employeeId,studyEntity);
            _skillMatrixRepository.Save();
            var studyToReturn = _mapper.Map<StudyDto>(studyEntity);
            return CreatedAtRoute("GetStudyForEmployee",
                new { employeeId = employeeId, studyId = studyToReturn.Id },
                studyToReturn);
        }

        [HttpPut("{employeeId}/{studyId}")]
        public IActionResult UpdateStudyForEmployee(Guid employeeId, Guid studyId, StudyForUpdateDto study)
        {
            if (!_skillMatrixRepository.EmployeeExists(employeeId))
            {
                return NotFound();
            }
            var studyForEmployeeFromRepo = _skillMatrixRepository.GetStudy(employeeId, studyId);
            if (studyForEmployeeFromRepo == null)
            {
                var studyToAdd = _mapper.Map<Entities.Study>(study);
                studyToAdd.Id = employeeId;

                _skillMatrixRepository.AddStudy(employeeId, studyToAdd);
                _skillMatrixRepository.Save();
                var studyToReturn = _mapper.Map<StudyDto>(studyToAdd);
                return CreatedAtRoute("GetStudyForEmployee",
                    new { employeeId = employeeId, studyId = studyToReturn.Id },
                    studyToReturn);
            }
            _mapper.Map(study, studyForEmployeeFromRepo);
            _skillMatrixRepository.UpdateStudy(studyForEmployeeFromRepo);
            _skillMatrixRepository.Save();
            return NoContent();
        }

        ///tbd
        [HttpPatch("{employeeId}/{studyId}")]
        public ActionResult PartiallyUpdateStudyForEmployee(Guid employeeId,
           Guid studyId,
           JsonPatchDocument<StudyForUpdateDto> patchDocument)
        {
            if (!_skillMatrixRepository.EmployeeExists(employeeId))
            {
                return NotFound();
            }

            var studyForEmployeeFromRepo = _skillMatrixRepository.GetStudy(employeeId, studyId);

            if (studyForEmployeeFromRepo == null)
            {
                /*                var courseDto = new StudyForUpdateDto();
                                patchDocument.ApplyTo(StudyDto, ModelState);

                                if (!TryValidateModel(courseDto))
                                {
                                    return ValidationProblem(ModelState);
                                }

                                var courseToAdd = _mapper.Map<Entities.Course>(courseDto);
                                courseToAdd.Id = courseId;

                                _courseLibraryRepository.AddCourse(authorId, courseToAdd);
                                _courseLibraryRepository.Save();

                                var courseToReturn = _mapper.Map<CourseDto>(courseToAdd);

                                return CreatedAtRoute("GetCourseForAuthor",
                                    new { authorId, courseId = courseToReturn.Id },
                                    courseToReturn);*/
                return NotFound();
            }

            var studyToPatch = _mapper.Map<StudyForUpdateDto>(studyForEmployeeFromRepo);
            // add validation
            patchDocument.ApplyTo(studyToPatch);
/*
            if (!TryValidateModel(studyToPatch))
            {
                return ValidationProblem(ModelState);
            }*/

            _mapper.Map(studyToPatch, studyForEmployeeFromRepo);

            _skillMatrixRepository.UpdateStudy(studyForEmployeeFromRepo);

            _skillMatrixRepository.Save();

            return NoContent();
        }


        [HttpDelete("{employeeId}/{studyId}")]
        public ActionResult DeleteStudyForEmployee(Guid employeeId, Guid studyId)
        {
            if (!_skillMatrixRepository.EmployeeExists(employeeId))
            {
                return NotFound();
            }

            var studyForEmployeeFromRepo = _skillMatrixRepository.GetStudy(employeeId, studyId);

            if (studyForEmployeeFromRepo == null)
            {
                return NotFound();
            }

            _skillMatrixRepository.DeleteStudy(studyForEmployeeFromRepo);
            _skillMatrixRepository.Save();

            return NoContent();
        }

    }
}

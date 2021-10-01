using Estant.Core.Handlers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estant.API.Controllers
{
    public class ExerciseController : BaseController
    {
        #region Contructor
        private readonly ExerciseHandler _exerciseHandler;
        public ExerciseController(ExerciseHandler exerciseHandler)
        {
            _exerciseHandler = exerciseHandler;
        }
        #endregion

        [HttpGet("GetByTopic")]
        public async Task<IActionResult> GetByTopic(string topic)
        {
            return Ok();
        }
    }
}

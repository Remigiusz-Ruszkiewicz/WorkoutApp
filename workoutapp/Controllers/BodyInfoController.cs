using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using workoutapp.Contracts;
using workoutapp.Models;
using workoutapp.Services;

namespace workoutapp.Controllers
{
    public class BodyInfoController : Controller
    {
        public BodyInfoController(IBodyInfoService bodyInfoService)
        {
            BodyInfoService = bodyInfoService;
        }

        public IBodyInfoService BodyInfoService { get; }

        [AllowAnonymous]
        [HttpPost(ApiRoutes.BodyInfo.BmiResult)]
        public async Task<IActionResult> BmiResult([FromBody] BMICalculator BMICalculator)
        {
            var bmiseresult = await BodyInfoService.BMIResultAsync(BMICalculator);
            return Ok(bmiseresult);
        }
        [AllowAnonymous]
        [HttpGet(ApiRoutes.BodyInfo.BmiResultALL)]
        public async Task<IActionResult> BmiResultALL()
        {
            var exercises = await BodyInfoService.BmiResultAllAsync();
            return Ok(exercises);
        }
        [AllowAnonymous]
        [HttpPost(ApiRoutes.BodyInfo.AddBodyMeasure)]
        public async Task<IActionResult> AddBodyMeasure([FromBody] BodyMeasure bodyMeasure)
        {
            var bodyMeasureResult = await BodyInfoService.AddBodyMeasureAsync(bodyMeasure);
            return Ok(bodyMeasureResult);
        }
        [AllowAnonymous]
        [HttpGet(ApiRoutes.BodyInfo.GetAllBodyMeasures)]
        public async Task<IActionResult> GetAllBodyMeasures()
        {
            var measures = await BodyInfoService.GetAllBodyMeasuresAsync();
            return Ok(measures);
        }
    }
}

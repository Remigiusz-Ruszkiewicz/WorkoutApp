using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using workoutapp.Contracts;
using workoutapp.Contracts.Request;
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
        public async Task<IActionResult> BmiResult([FromBody] BMIRequest BMIRequest)
        {
            var bmiseresult = await BodyInfoService.BMIResultAsync(BMIRequest);
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
        [AllowAnonymous]
        [HttpPost(ApiRoutes.BodyInfo.AddBodyFatCalculation)]
        public async Task<IActionResult> AddBodyFatCalculation([FromBody] BodyFatCalculator bodyFatCalculator)
        {
            var bodyMeasureResult = await BodyInfoService.AddBodyFatCalculation(bodyFatCalculator);
            return Ok(bodyMeasureResult);
        }
        [AllowAnonymous]
        [HttpGet(ApiRoutes.BodyInfo.GetAllBodyFatCalculations)]
        public async Task<IActionResult> GetAllBodyFatCalculations()
        {
            var bodyfat = await BodyInfoService.GetAllBodyFatCalculations();
            return Ok(bodyfat);
        }
    }
}

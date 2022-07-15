using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workoutapp.Contracts.Request;
using workoutapp.Models;

namespace workoutapp.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IBodyInfoService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="BMIRequest"></param>
        Task<double> BMIResultAsync(BMIRequest BMIRequest);
        /// <summary>
        /// 
        /// </summary>
        Task<ICollection<BMICalculator>> BmiResultAllAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bodyMeasure"></param>
        Task<BodyMeasure> AddBodyMeasureAsync(BodyMeasure bodyMeasure);
        /// <summary>
        /// 
        /// </summary>
        Task<ICollection<BodyMeasure>> GetAllBodyMeasuresAsync();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bodyFatCalculator"></param>
        Task<BodyFatCalculator> AddBodyFatCalculation(BodyFatCalculator bodyFatCalculator);
        /// <summary>
        /// 
        /// </summary>
        Task<ICollection<BodyFatCalculator>> GetAllBodyFatCalculations();
    }
}

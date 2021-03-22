using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workoutapp.Contracts.Request;
using workoutapp.Models;

namespace workoutapp.Services
{
    public interface IBodyInfoService
    {
        Task<double> BMIResultAsync(BMIRequest BMIRequest);
        Task<ICollection<BMICalculator>> BmiResultAllAsync();

        Task<BodyMeasure> AddBodyMeasureAsync(BodyMeasure bodyMeasure);
        Task<ICollection<BodyMeasure>> GetAllBodyMeasuresAsync();

        Task<BodyFatCalculator> AddBodyFatCalculation(BodyFatCalculator bodyFatCalculator);
        Task<ICollection<BodyFatCalculator>> GetAllBodyFatCalculations();
    }
}

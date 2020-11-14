using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workoutapp.Data;
using workoutapp.Models;

namespace workoutapp.Services
{
    public class BodyInfoService : IBodyInfoService
    {
        public BodyInfoService(DataContext dbContext)
        {
            DbContext = dbContext;
        }

        public DataContext DbContext { get; }

        public async Task<BodyFatCalculator> AddBodyFatCalculation(BodyFatCalculator bodyFatCalculator)
        {
            bodyFatCalculator.Date = DateTime.Now;
            bodyFatCalculator.Id = Guid.NewGuid();
            double bf;
            if (bodyFatCalculator.Gender == false)
            {
                bf = 495 / (1.0324 - 0.19077 * Math.Log(bodyFatCalculator.Waist - bodyFatCalculator.Neck, 10) + 0.15456 * Math.Log(bodyFatCalculator.Height, 10)) - 450;
            }
            else
            {
                bf = 495 / (1.29579 - 0.35004 * Math.Log(bodyFatCalculator.Waist + bodyFatCalculator.Hip - bodyFatCalculator.Neck, 10) + 0.22100 * Math.Log(bodyFatCalculator.Height, 10)) - 450;
            }
            bf = Math.Round(bf, 1);
            bodyFatCalculator.FatMass = Math.Round((bf/100 * bodyFatCalculator.Weight),1);
            bodyFatCalculator.LeanMass = bodyFatCalculator.Weight - bodyFatCalculator.FatMass;
            if (bodyFatCalculator.Save == false)
            {
                return bodyFatCalculator; 
            }
            bodyFatCalculator.BodyFatPercentage = bf;
            DbContext.BodyFatCalculator.Add(bodyFatCalculator);
            await DbContext.SaveChangesAsync();
            return bodyFatCalculator;
        }

        public async Task<BodyMeasure> AddBodyMeasureAsync(BodyMeasure bodyMeasure)
        {
            bodyMeasure.Id = Guid.NewGuid();
            bodyMeasure.Date = DateTime.Now;
            DbContext.BodyMeasure.Add(bodyMeasure);
            await DbContext.SaveChangesAsync();
            return bodyMeasure;

        }

        public async Task<ICollection<BMICalculator>> BmiResultAllAsync()
        {
            var result = await DbContext.BMIResults.ToListAsync();
            return result;
        }

        public async Task<double> BMIResultAsync(BMICalculator bMICalculator)
        {
            bMICalculator.Date = DateTime.Now;
            bMICalculator.Id = Guid.NewGuid();
            double height = bMICalculator.Height;
            var weight = bMICalculator.Weight;
            double Bmi = Math.Round((weight / ((height / 100) * (height / 100))), 1);
            if (bMICalculator.Save == false)
            {
               return Bmi;
            }
            bMICalculator.Result = Bmi;
            DbContext.BMIResults.Add(bMICalculator);
            await DbContext.SaveChangesAsync();
            return Bmi;
        }

        public async Task<ICollection<BodyFatCalculator>> GetAllBodyFatCalculations()
        {
            var result = await DbContext.BodyFatCalculator.ToListAsync();
            return result;
        }

        public async Task<ICollection<BodyMeasure>> GetAllBodyMeasuresAsync()
        {
            var result = await DbContext.BodyMeasure.ToListAsync();
            return result;
        }
    }
}

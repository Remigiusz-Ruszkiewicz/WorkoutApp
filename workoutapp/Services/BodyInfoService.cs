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

        public async Task<ICollection<BodyMeasure>> GetAllBodyMeasuresAsync()
        {
            var result = await DbContext.BodyMeasure.ToListAsync();
            return result;
        }
    }
}

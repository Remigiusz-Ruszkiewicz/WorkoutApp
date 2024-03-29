﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using workoutapp.Contracts.Request;
using workoutapp.Data;
using workoutapp.Models;

namespace workoutapp.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class BodyInfoService : IBodyInfoService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbContext"></param>
        public BodyInfoService(DataContext dbContext)
        {
            DbContext = dbContext;
        }

        /// <summary>
        /// 
        /// </summary>
        public DataContext DbContext { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bodyFatCalculator"></param>
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
            bodyFatCalculator.FatMass = Math.Round(bf/100 * bodyFatCalculator.Weight,1);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bodyMeasure"></param>
        public async Task<BodyMeasure> AddBodyMeasureAsync(BodyMeasure bodyMeasure)
        {
            bodyMeasure.Id = Guid.NewGuid();
            bodyMeasure.Date = DateTime.Now;
            DbContext.BodyMeasure.Add(bodyMeasure);
            await DbContext.SaveChangesAsync();
            return bodyMeasure;

        }

        /// <summary>
        /// 
        /// </summary>
        public async Task<ICollection<BMICalculator>> BmiResultAllAsync()
        {
            var result = await DbContext.BMIResults.ToListAsync();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="BMIRequest"></param>
        public async Task<double> BMIResultAsync(BMIRequest BMIRequest)
        {
            BMICalculator calc = new() { Date = DateTime.Now, Id = Guid.NewGuid(), Height = BMIRequest.height , Weight = BMIRequest.weight };
            double height = BMIRequest.height;
            var weight = BMIRequest.weight;
            double Bmi = Math.Round(weight / (height / 100 * (height / 100)), 1);
            if (BMIRequest.save == false)
            {
               return Bmi;
            }
            calc.Result = Bmi;
            DbContext.BMIResults.Add(calc);
            await DbContext.SaveChangesAsync();
            return Bmi;
        }

        /// <summary>
        /// 
        /// </summary>
        public async Task<ICollection<BodyFatCalculator>> GetAllBodyFatCalculations()
        {
            var result = await DbContext.BodyFatCalculator.ToListAsync();
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        public async Task<ICollection<BodyMeasure>> GetAllBodyMeasuresAsync()
        {
            var result = await DbContext.BodyMeasure.ToListAsync();
            return result;
        }
    }
}

﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }


        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile formFile, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfCarImagesCount(carImage.CarId));
            if (result != null)
            {
                return result;
            }

            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImagesAdded);

        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.CarImagesListed);
        }

        public IDataResult<CarImage> GetByCarId(int carId)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(ci => ci.CarId == carId));
        }

        public IResult Update(CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfCarImagesCount(carImage.CarId));
            if (result != null)
            {
                return result;
            }

            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.CarImagesUpdated);
        }

        private IResult CheckIfCarImagesCount(int id)
        {
            var result = _carImageDal.GetAll(ci => ci.CarId == id).Count;

            if (result > 5)
            {
                return new ErrorResult(Messages.CarImageCountError);
            }
            return new SuccessResult();
        }

       
        public IDataResult<List<CarImage>> GetCarImages(int carId)
        {
            var path = Path.GetExtension(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName + @"DefaultImage / default.jfif");
            var result = _carImageDal.GetAll(ci => ci.CarId == carId).Any();
            if (!result)
            {
                List<CarImage> carImages = new List<CarImage> { new CarImage { CarId = carId, ImagePath = path, Date = DateTime.Now } };
                return new ErrorDataResult<List<CarImage>>(carImages,Messages.CarImagesNotFound);
            }
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(ci => ci.CarId == carId));
        }

        public IDataResult<List<CarImageDetailDto>> GetCarImagesDetail()
        {
            return new SuccessDataResult<List<CarImageDetailDto>>(_carImageDal.GetCarImageDetails());
        }

    }
}

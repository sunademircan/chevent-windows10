﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage.Pickers.Provider;

namespace chevent.Windows10.Data.Domain.Business
{
    public interface IServiceResult
    {
        bool HasError { get; set; }
        bool Success { get; }
        int ResultCode { get; set; }
    }



    public class ServiceResult : IServiceResult
    {
        public bool HasError { get; set; }

        public bool Success
        {
            get { return !HasError; }
        }

        public int ResultCode { get; set; }

        public static ServiceResult Instance
        {
            get { return new ServiceResult(); }
        }

        private ServiceResult()
        {
        }

        public ServiceResult ErroResult(int resultCode)
        {
            return SetResult(true, resultCode);
        }

        public ServiceResult SuccessResult()
        {
            return SetResult(false, 0);
        }

        public ServiceResult SuccessResult(int resultCode)
        {
            return SetResult(false, resultCode);
        }

        private ServiceResult SetResult(bool hasError, int resultCode)
        {
            HasError = hasError;
            ResultCode = resultCode;
            return this;
        }
    }

    public class ServiceResult<T> : IServiceResult
    {
        public T ResultValue { get; set; }
        public bool HasError { get; set; }
        public bool Success { get { return !HasError; } }
        public int ResultCode { get; set; }

        public static ServiceResult<T> Instance
        {
            get { return new ServiceResult<T>(); }
        }

        private ServiceResult() { }

        public ServiceResult<T> ErroResult(int resultCode)
        {
            return SetResult(true, ResultCode, default(T));
        }

        public ServiceResult<T> SuccessResult(T resultValue)
        {
            return SetResult(false, 0, resultValue);
        }

        public ServiceResult<T> SuccessResult(T resultValue, int resultCode)
        {
            return SetResult(false, resultCode, resultValue);
        }

        public ServiceResult<T> SetResult(bool hasError, int resultCode, T resultValue)
        {
            ResultValue = resultValue;
            HasError = hasError;
            ResultCode = resultCode;
            return this;
        }
    }




}


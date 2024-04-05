﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core
{
    public class OperationResult
    {
        public OperationResult()
        {
            IsSuccedded = false;
        }

        public bool IsSuccedded { get; set; }
        public string Message { get; set; }

        public OperationResult Succedded(string message = "عملیات با موفقیت انجام شد")
        {
            IsSuccedded = true;
            Message = message;
            return this;
        }

        public OperationResult Failed(string message)
        {
            IsSuccedded = false;
            Message = message;
            return this;
        }

    }
}

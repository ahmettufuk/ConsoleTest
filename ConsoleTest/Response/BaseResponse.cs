using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Response
{
    public class BaseResponse
    {
        public bool IsSuccess;
        public BaseResponse(bool isSuccess)
        {
            this.IsSuccess = isSuccess;
        }

    }

    public class BaseResponse<T> : BaseResponse
    {
        public T Data;

        public BaseResponse(T data,bool isSuccess) : base(isSuccess)
        {
            Data = data;
        }

    
    }
}

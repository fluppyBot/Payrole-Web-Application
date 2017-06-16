using MediatR;
using PAYROLE.FRAMEWORK.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLE.FRAMEWORK.Queries
{
    public class TestQuery: IRequest<TestResult>
    {
        public int TestValue { get; set; }
    }
}

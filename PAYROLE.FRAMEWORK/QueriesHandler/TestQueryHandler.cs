using MediatR;
using PAYROLE.FRAMEWORK.Models;
using PAYROLE.FRAMEWORK.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace PAYROLE.FRAMEWORK.QueriesHandler
{
    public class TestQueryHandler : IRequestHandler<TestQuery, TestResult>
    {

        public TestResult Handle(TestQuery message)
        {
            return new TestResult { Result = 100 };
        }
    }
}

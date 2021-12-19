using Core.Utilitiess.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilitiess.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logisc)
        {
            foreach (var logic in logisc)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}

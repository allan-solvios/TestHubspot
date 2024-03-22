using Cannolai.Hubspot.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole1
{
    public static class TestData
    {
        public static ContactColumn CustomerIDColumn { get; } = new ContactColumn
        {
            name = "x_CustomerID",
            label = "x_Customer ID",
            description = null,
            type = "number",
            fieldType = "number",
            formField = true,
            displayOrder = -1,
            groupName = "cannolai",
            hidden = false,
            isRequired = true
        };
    }
    
}

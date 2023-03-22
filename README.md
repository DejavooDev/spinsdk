# Dejavoo.Spin.Sdk - the C# library for the SPIn integration 

![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/DejavooDev/spinsdk/build.yml)
![Nuget](https://img.shields.io/nuget/dt/Dejavoo.Spin.Sdk?style=flat-square)

- API version: v2
- SDK version: 1.0.0

<a name="frameworks-supported"></a>
## Frameworks supported
- netstandard2.1 or later

## Installation
Run the following command to add package reference
```
dotnet add package Dejavoo.Spin.Sdk 
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Dejavoo.Spin.Sdk.Client.Api;
using Dejavoo.Spin.Sdk.Client.Client;
using Dejavoo.Spin.Sdk.Client.Model;

namespace Example
{
    public class Example
    {
        public void Main(string[] args)
        {
            IOperationExecutor executor = Spin.V2.CreateExecutor("your_tpn_id", "your_api_key");

            IOperation<SaleResponse> operation = Operations.Sale(1.0f);

            SaleResponse response = await operation.ExecuteAsync(executor);
            
            Debug.WriteLine(response);
        }
    }
}
```

<a name="operations"></a>
## Supported Operations

### Sale
```csharp
// A 15$ sale operation
IOperation<SaleResponse> sale = Operations.Sale(15);
```
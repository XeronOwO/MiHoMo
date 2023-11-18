# MiHoMo
## Introduction / 简介
A C# library for API wrapper data from https://api.mihomo.me/  
对 https://api.mihomo.me/ API的C#封装库  
## Installation / 安装
Download .nupkg from Releases.  
Or install from NuGet by searching MiHoMo.  
从 Releases 中下载 .nupkg 文件。  
或者在 NuGet 搜索 MiHoMo 安装。  
## Usage / 使用方法
```csharp
using MiHoMo;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestAsync().Wait();
        }

        private static async Task TestAsync()
        {
            using var api = new MiHoMoAPI(); // Create MiHoMo API
            await api.InitAllResourcesAsync(); // Initialize all resources
            // var originInfo = await api.GetOriginInfoAsync(102176371);
            var parsedInfo = await api.GetParsedInfoAsync(100000000); // Get parsed info by UID

            // TODO ...
        }
    }
}
```

// #r @"../../packages/FSharp.Management/lib/net40/FSharp.Management.PowerShell.ExternalRuntime.exe"
// #r @"../../packages/FSharp.Management/lib/net40/FSharp.Management.PowerShell.dll"
// #r @"../../packages/FSharp.Management/lib/net40/FSharp.Management.WMI.DesignTime.dll"
// #r @"../../packages/FSharp.Management/lib/net40/FSharp.Management.WMI.dll"
// #r @"../../packages/FSharp.Management/lib/net40/FSharp.Management.dll"
// #r @"/usr/lib/mono/4.5-api/System.Core.dll"
// #r @"../../packages/FSharp.Management/lib/net40/System.Management.Automation.dll"
// #r @"/usr/lib/mono/4.5-api/System.Numerics.dll"
// #r @"/usr/lib/mono/4.5-api/System.Xml.Linq.dll"
// #r @"/usr/lib/mono/4.5-api/System.dll"
// #load @"/home/ed/git/alsocloudtfs.visualstudio.com/fun-fun/src/FunFun/Process.fs"
#r @"packages/FSharp.Data/lib/net40/FSharp.Data.dll"
#load @"/home/ed/git/alsocloudtfs.visualstudio.com/fun-fun/src/FunFun/Acm.fs"
// #load @"/home/ed/git/alsocloudtfs.visualstudio.com/fun-fun/src/FunFun/FunFun.fs"

Acm.authenticate
  "https://marketplacetest.ccpaas.net/DataModel/service.svc/rest/IAuthorizationService/Authenticate"
  "eduard.ilyin@nervogrid.com"
  "***"
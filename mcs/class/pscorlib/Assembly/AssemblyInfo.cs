// Copyright 2013 Zynga Inc.
//	
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//		
//      Unless required by applicable law or agreed to in writing, software
//      distributed under the License is distributed on an "AS IS" BASIS,
//      WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//      See the License for the specific language governing permissions and
//      limitations under the License.

using System;
using System.Reflection;
using System.Resources;
using System.Security;
using System.Security.Permissions;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about the assembly
//
[assembly: AssemblyTitle("pscorlib")]
[assembly: AssemblyDescription("Core PlayScript framework library")]
[assembly: AssemblyDefaultAlias ("pscorlib.dll")]

[assembly: AssemblyCompany("PlayScriptRedux")]
[assembly: AssemblyProduct("PlayScript")]
[assembly: AssemblyCopyright("")]

[assembly: AssemblyVersion (Consts.FxVersion)]
[assembly: SatelliteContractVersion (Consts.FxVersion)]
[assembly: AssemblyInformationalVersion (Consts.FxFileVersion)]
[assembly: AssemblyFileVersion (Consts.FxFileVersion)]

[assembly: NeutralResourcesLanguage ("en-US")]
//[assembly: CLSCompliant (true)]
[assembly: AssemblyDelaySign (true)]

[assembly: AssemblyKeyFile ("../ecma.pub")]

[assembly: SecurityCritical]

[assembly: ComVisible (false)]


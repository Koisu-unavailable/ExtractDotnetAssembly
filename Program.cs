using dnlib.DotNet;


class Program
{
    public static void Main(string[] args)
    {
        if (args.Length < 2 || args.Length > 2)
        {
            Console.WriteLine("Usage: extractdotnetassembly <exe_file> [output_filename]");
        }

        ModuleContext modCtx = ModuleDef.CreateModuleContext();
        ModuleDefMD module = ModuleDefMD.Load(args.First(), modCtx);
        module.Write(args.Length == 2 ? args[1] : (args.First() + ".dll"));
    }
}

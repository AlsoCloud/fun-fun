namespace FunFun

open System.Management.Automation


[<Cmdlet("VerbsCommon.Get","Fun")>]
type FortyTwoCmdlet() = 
    inherit PSCmdlet()

    [<Parameter()>]
    member val Radius = 0.0 with get, set

    override this.ProcessRecord() =
        Process.circleSquare this.Radius
            |> this.WriteObject

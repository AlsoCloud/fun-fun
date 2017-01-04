namespace FunFun

open System.Management.Automation


[<Cmdlet(VerbsCommon.Get,"Fun")>]
type FortyTwoCmdlet() = 
    inherit PSCmdlet()

    [<Parameter(Mandatory = true, Position = 0)>]
    member val Radius : float = 0.0 with get, set

    override this.ProcessRecord() =
       System.Math.PI * pown this.Radius 2 |> this.WriteObject

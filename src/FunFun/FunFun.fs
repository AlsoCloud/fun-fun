namespace FunFun

open System.Management.Automation

type Tone =
    | Idi
    | Vnimanije
    | Stoj

type Luxofor =
    | RedGreen of int * Tone
    | YellowYellow of int * Tone
    | GreenRed of int * Tone


[<Cmdlet(VerbsCommon.Get,"Fun")>]
type FortyTwoCmdlet() = 
    inherit PSCmdlet()

    [<Parameter(Mandatory = true, Position = 0)>]
    member val Radius : float = 0.0 with get, set

    override this.ProcessRecord() =
        let mutable state = GreenRed (10, Idi)
        do state <-
            match state with
                | RedGreen (seconds, tone) -> YellowYellow (5, toneState tone)
                | YellowYellow (seconds, tone) -> GreenRed
                | _ -> RedGreen
        state |> this.WriteObject
// module Result

type Result<'TErr,'TOk> =
    | Err of 'TErr
    | Ok of 'TOk


let andThen func result =
    match result with
        | Err msg -> Err msg
        | Ok value -> func value


let map func result =
    match result with
        | Err msg -> Err msg
        | Ok value -> func value |> Ok

let unpack errFunc okFunc result =
    match result with
        | Err msg -> errFunc msg
        | Ok value -> okFunc value


type Cvet =
    | Krasnij
    | Zholtij
    | Zeljonij


let parseString value =
    match value with
        | "krasnij" -> Ok Krasnij
        | "zholtij" -> Ok Zholtij
        | "zeljonij" -> Ok Zeljonij
        | _ -> sprintf "I don't know such word '%s'" value |> Err


let perekljuchitkSvetofor svetofor =
    match svetofor with
        | Krasnij -> Zholtij
        | Zholtij -> Zeljonij
        | Zeljonij -> Krasnij


let perekljuchajem cvetBukvami =
    cvetBukvami
        |> parseString
        |> map perekljuchitkSvetofor
        |> map perekljuchitkSvetofor
        |> unpack id (sprintf "Cvet: %A")


perekljuchajem "krasnij"
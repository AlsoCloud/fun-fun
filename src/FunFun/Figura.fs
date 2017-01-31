module Figura

type Koordinata<'T> = {
    x: 'T
    y: 'T
    z: 'T
}


type Figura<'T> =
    | Priamougolnik of ugol1: Koordinata<'T> * ugol2: Koordinata<'T>
    | Krug of centr: Koordinata<'T> * radius: 'T


let curry f x y = f (x, y)


let sdvigVPravo sdvig objekt =
    match objekt with
        | Krug (koordinata, radius) ->
            curry Krug
                { koordinata with x = koordinata.x + sdvig }
                radius

        | Priamougolnik (u1, u2) ->
            curry Priamougolnik
                { u1 with x = u1.x + sdvig }
                { u2 with x = u2.x + sdvig }


let kruzhok = Krug ({x = 2.0; y = 23.2; z = 33.0}, 50.2)


sdvigVPravo 42.0 kruzhok

// type Result<'TSuccess, 'TFailure> =
//     | Success of 'TSuccess
//     | Failure of 'TFailure

let tryGetFromServe x = Failure "Server sdoh"


let a = 5 + 6


type Option<'T> =
    | None
    | Some of 'T

let o1 = Some "aaaasd"




type Result<'TErr,'TOk> =
    | Err of 'TErr
    | Ok of 'TOk

let tryHead list =
    match list with
      | [] -> Err "Что-то не могу найти голову"
      | golova::hvost -> Ok golova

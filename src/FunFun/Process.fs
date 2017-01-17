module Process


let circleSquare radius =
    radius ** 2.0
        |> (*) System.Math.PI

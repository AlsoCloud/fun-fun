module Acm

open FSharp.Data

let authenticate url username password =
    let body =
        sprintf
            """{
                userName: "%s",
                password: "%s"
            }"""
            username
            password
            |> HttpRequestBody.TextRequest

    Http.RequestString
        ( url = url
        , body = body
        )

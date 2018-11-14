module FableProject.Tests

open Fable.Import.Jest
open Matchers
open FableProject.Library

test "Basic sum test" <| fun () ->
    sum 7 4 == 11
module FableProject.App

open FableProject.Library
open Fable.Core.JsInterop
open Fable.Import.Browser

let canvas = 
    document.getElementsByTagName_canvas()
    |> fun nodeList -> nodeList.item(0.)

let ctx = canvas.getContext_2d()
ctx.clearRect(0.,0.,canvas.width,canvas.height)

ctx.beginPath()
ctx.moveTo(70., 90.)
ctx.lineTo(120., 15.)
ctx.lineTo(170., 90.)
ctx.fillStyle <- !^"rgba(46, 49, 49, 0.40)"
ctx.fill()

ctx.beginPath()
ctx.moveTo(50.,100.)
ctx.lineTo(100., 25.)
ctx.lineTo(150., 100.)
ctx.fillStyle <- !^"rgba(38, 166, 91, 0.80)"
ctx.fill()
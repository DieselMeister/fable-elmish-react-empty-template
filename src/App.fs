module App

open Elmish
open Elmish.Browser.Navigation
open Elmish.Browser.UrlParser
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Fable.Import.Browser


importAll "../sass/main.sass"

open Fable.Helpers.React
open Fable.Helpers.React.Props




(*
    Here add you model, messages, init, update and view

    use bulma.io

    use ClassName to set class name
*)


open Elmish.React
open Elmish.Debug
open Elmish.HMR

// App
Program.mkProgram init update view
#if DEBUG
|> Program.withDebugger
#endif
|> Program.withReact "elmish-app"
|> Program.run

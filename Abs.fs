namespace Mahamudra.TheAlgorithms

module Abs =
    let abs x = 
        match x with
        | x when x < 0 ->  -x 
        | _ -> x

    let abs' x = 
        match x with
        | x when x < 0. ->  -x 
        | _ -> x

    let abs'' x = 
        match x with
        | x when x < 0M ->  -x 
        | _ -> x 
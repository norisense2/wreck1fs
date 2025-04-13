namespace Wreck1

type Type =
    | Bool
    | Int of uint
    | Uint of uint
    | Float of uint
    | Struct of Member list
    | Array of Type

and Member = {name : string; type_ : Type}


//tokenをTypeにする関数たちのモジュールを書く

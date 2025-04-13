module Wreck1.AST

type Stmt =
    | Func of FuncStmt
    | Var of VarStmt
    | Const of ConstStmt
    | While of WhileStmt
    | If of IfStmt
    | Return of ReturnStmt
    | Do of DoStmt

and FuncStmt = {
    name : string;
    args : Arg list;
    type_ : Type;
    expr : Expr;
    stmt : Stmt;
}

and VarStmt = {
    name : string;
    type_ : Type;
    expr : Expr;
}

and ConstStmt = {
    name : string;
    type_ : Type;
    expr : Expr;
}

and WhileStmt = {
    
}

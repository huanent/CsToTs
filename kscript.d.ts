declare const k: CSharpToTypescriptDefine.KScript;
declare namespace CSharpToTypescriptDefine {
   interface KScript {
       user:User;
       execute(code:string,user:User):void;
   }

   interface User {
       name:string;
       pwd:string;
       age:number;
       id:number;
   }

}

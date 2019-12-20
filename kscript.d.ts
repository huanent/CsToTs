declare namespace CSharpToTypescriptDefine {
   interface KScript  {
       user:User;
       execute(code:string,user:User):void;
   }

   interface User  {
       name:string;
       pwd:string;
       age:number;
       id:number;
       kType:KType;
   }

}
   declare enum KType {
       aaa=0,
       bbb=1,
   }


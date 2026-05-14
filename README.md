the difference between class , struct , record : 
class : reference type, يعنى لو عملت  two object من class وجيت قارنتهم ببعض هيطلع false بس الاتنين لو غيرت فى value بتاعت attribute هتسمع فى التانى ,stored in heap 
struct: value type, هنا لو اخذت two object من struct وجيت قارنتهم ببعض هيبقوا equal علشان انا باخذ copy بس مش هيسمعوا فى بعض ,stored in stack
record: reference type but comparison by value type :هنا بقا لو اخذت two object من record وجيت قارنتهم ببعض هيطلع true  ,stored in heap

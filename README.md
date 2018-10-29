# Wcf
Reproduces connected wcf service reference error

The InternalService project has a service reference to ExternalService.  ExternalService is not directly required, but I included it for completeness.  Run InternalService compiled for debug and you will be able to add a reference in .net core and the existing .net framework generator (I was using an MVC 4 application).  If you compile for release you will only be able to add it with the existing generator.  However, if you append ?singleWsdl to the url then it will work in .net core as well.  

IE This works:
http://localhost:57080/InternalService.svc?singleWsdl 
works, while this does not:
http://localhost:57080/InternalService.svc does not.

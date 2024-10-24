
// Türeyen sınıfı bir nesne örneği alalım!!

B be = new B();
be.Aciklama="Türeyen sınıf";

// b bir sınıf ve a sınıfından türüyor, aynı zamanda a sınıfın açıklama isminde bir propu kalıtım ile b sınıfına geçmiş!!

// bu hiyerarşide, çalışma zamanında nasıl bir bellek hareketlenmesi yaşar!!

B birinci = new B();

// Türeyen ve türetilen sınıflarda, belleğe çıkma işlemi şu şekildedir

// her zaman ilk olarak türeyen sınıf yani kalıtımın en üst mertebesindeki sınıf belleğe çıkmak zorundadır!!

// bu örnekte aslında bu konunun nasıl olduğuna ve nasıl çalıştığına baktık

// A sınıfı Base Class  B Sınıfı Drived Class A sınfıından türeyen sınıf
// B sınıfın nesne örneğini aldığımızda, ilk olarak A sınıfına ait default ctor çalışır

// A sınıfı belleğe çıkar, daha sonra, B sınıfının ctor'u çalışır!!


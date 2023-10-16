https://t3n.de/news/prinzipien-software-entwicklung-solid-615556/

# S“ wie „Single-Responsibility-Prinzip“ 

***„Es sollte nie mehr als einen Grund dafür geben, eine Klasse zu ändern.“ Robert C. Martin***
	
Die Kernaussage des Prinzips ist, dass jede Klasse und jede Methode nur genau eine fest definierte Aufgabe zu erfüllen hat. Wenn eine Klasse mehrere Verantwortungen zu tragen hat, führt das zu Schwierigkeiten bei zukünftigen Änderungen und das Fehlerrisiko steigt. Eine hohe Kohäsion – also alle Methoden innerhalb einer Klassen haben einen starken gemeinsamen Bezug – sollte angestrebt werden.
	
# „O“ wie „Open-Closed-Prinzip“
	
***„Module sollten sowohl offen (für Erweiterungen) als auch geschlossen (für Modifikationen) sein.“ Bertrand Meyer***
	
Dieses Prinzip besagt, dass Klassen, Methoden, Module etc. so entwickelt werden sollen, dass sie einfach zu erweitern sind – ohne aber ihr Verhalten zu ändern. Das beste Beispiel dafür ist wohl die Vererbung. Das Verhalten einer Klasse wird nicht verändert, erhöht aber trotzdem die Funktionalität der Software. Auch das Überschreiben von Methoden verändert nicht das Verhalten der Basisklasse, sondern nur die Methoden der abgeleiteten Klasse.
	
# „L“ wie „Liskovsches Substitutionsprinzip“
	
***„Sei q(x) eine Eigenschaft des Objektes x vom Typ T, dann sollte q(y) für alle Objekte y des Typs S gelten, wobei S ein Subtyp von T ist.“ Barbara Liskov***
	
Einfach gesagt: Das (Ersetzungs-)Prinzip sagt aus, dass eine Subklasse immer alle Eigenschaften der Superklasse erfüllen und immer als Objekt der Superklasse verwendbar sein muss. Eine Subklasse darf somit Erweiterungen enthalten, aber keine grundlegenden Änderungen.
	
# „I“ wie „Interface-Segregation-Prinzip“
	
***„Clients sollten nicht dazu gezwungen werden, von Interfaces abzuhängen, die sie nicht verwenden.“ Robert C. Martin***
	
Wie der Name erahnen lässt, geht es hierbei darum, Interfaces aufzuspalten beziehungsweise sie nicht unnötig groß zu machen. Ein Interface soll also so gestaltetet sein, dass die Anforderungen des Clients erfüllt werden können. Damit soll vermieden werden, dass ein Client mehrere Interfaces nutzen muss, die er für seine eigentliche Anforderung gar nicht benötigt werden.
	
# „D“ wie „Dependency-Inversion-Prinzip“
	
***„A. Module hoher Ebenen sollten nicht von Modulen niedriger Ebenen abhängen. Beide sollten von Abstraktionen abhängen. B. Abstraktionen sollten nicht von Details abhängen. Details sollten von Abstraktionen abhängen.“ Robert C. Martin***
	
Das Prinzip beschäftigt sich mit der Abhängigkeit von abgeschlossenen funktionalen Einheiten einer Software – also Modulen. In Modulen, die eine höhere Hierarchie innerhalb der Software aufweisen, werden generelle Abläufe beschrieben, die von spezielleren Modulen verwendet werden. Je niedriger das Modul innerhalb der Hierarchie, desto spezifischere Probleme löst es.
Wenn ein hierarchisch niedriges Modul von einem höherliegendem Modul abhängig ist, entsteht ein Problem. Änderungen in spezifischen Modulen ändern somit das Verhalten von höher liegenden und generellen Modulen, eine zyklische Abhängigkeit entsteht und die Architektur und das Design der Software werden unnötig komplex. Das Prinzip soll also eine Invertierung der Abhängigkeiten sicherstellen.

/*
Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti che una banca concede ai propri clienti.

La banca è caratterizzata da
un nome
un insieme di clienti (una lista)
un insieme di prestiti concessi ai clienti (una lista)

I clienti sono caratterizzati da
nome,
cognome,
codice fiscale
stipendio

I prestiti sono caratterizzati da
ID
intestatario del prestito (il cliente),
un ammontare,
una rata,
una data inizio,
una data fine.

Per la banca deve essere possibile:
aggiungere, 
modificare e 
ricercare un cliente.

aggiungere un prestito.
effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.

sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.


Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo con tutti i dati 
che li caratterizzano in un formato di tipo stringa a piacere.

Bonus:
visualizzare per ogni cliente, la situazione dei suoi prestiti in formato tabellare.
*/


using csharp_banca_oop;

Banca banca = new Banca("BoolBank");

banca.clienti.Add(new Cliente("Test", "Prova", "aaa1", 100000));

banca.clienti.Add(new Cliente("Federico", "Orlando", "FDRRLD83D12L091C", 43500));
banca.clienti.Add(new Cliente("Antonio", "Verdi", "ATNVRD90R03T096X", 32300));
banca.clienti.Add(new Cliente("Martina", "Rossi", "MRTRSS97E05S092M", 25000));

banca.prestiti.Add(new Prestito(154324, banca.clienti[0], 23000, 7, 24610, 29, 848.62, 4, new DateTime(2021, 10, 10), new DateTime(2024, 03, 10)));

Menu.Start(banca);
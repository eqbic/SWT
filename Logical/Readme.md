# Stammbaum Mittelerde
Eine kleine Prologanwendung zum ueberpruefen von Verwandschaften in Mittelerde.

## Anwendung laden:
```prolog
?- [gondor].
true.
```
## Beispiele
```prolog
?- child_of(denethor, faramir).
true.

?- ancestor_of(barahir, denethor).
true.

?- descendant_of(thengel, elfwein).
true.

?- all_anchestors(elfwein, X).
X = [eomer, lothiriel, eomund, theodwyn, thengel, morwen].

?- all_descendants(ecthelion, X).
X = [denethor, boromir, faramir, elboron, barahir].
```
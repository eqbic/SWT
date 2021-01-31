/* Facts */
male(ecthelion).
male(adrahil).
male(thengel).
male(denethor).
male(eomund).
male(theoden).
male(boromir).
male(faramir).
male(eomer).
male(theodred).
male(elboron).
male(elfwein).
male(barahir).

female(morwen).
female(finduilas).
female(theodwyn).
female(elfhild).
female(eowyn).
female(lothiriel).

parent_of(barahir, elboron).
parent_of(elboron, faramir).
parent_of(elboron, eowyn).
parent_of(elfwein, eomer).
parent_of(elfwein, lothiriel).
parent_of(boromir, denethor).
parent_of(boromir, finduilas).
parent_of(faramir, denethor).
parent_of(faramir, finduilas).
parent_of(eowyn, eomund).
parent_of(eowyn, theodwyn).
parent_of(eomer, eomund).
parent_of(eomer, theodwyn).
parent_of(theodred, theoden).
parent_of(theodred, elfhild).
parent_of(denethor, ecthelion).
parent_of(finduilas, adrahil).
parent_of(theodwyn, thengel).
parent_of(theodwyn, morwen).
parent_of(theoden, thengel).
parent_of(theoden, morwen).

/* Rules */
child_of(X, Y) :- parent_of(Y, X).

ancestor_of(X, Y):- parent_of(X, Y).
ancestor_of(X, Y):- parent_of(X, Z),ancestor_of(Z, Y).

descendant_of(X, Y):- child_of(X, Y).
descendant_of(X, Y):- child_of(X, Z),descendant_of(Z, Y).

all_anchestors(X, L) :- findall(A, ancestor_of(X, A), L).
all_descendants(X, L) :- findall(A, descendant_of(X, A), L).
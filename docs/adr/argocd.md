# Integratie van Argo CD voor GitOps in Pitstop

**Status**: Besloten  
**Datum**: 29-10-2024  
**Auteur**: Luuk Lentjes

## Context

Binnen het Pitstop-project willen we een efficiënte en betrouwbare manier om onze Kubernetes-applicaties te beheren en te deployen. GitOps is de strategie die we willen volgen om consistentie, controle en automatisering te waarborgen. Voor het realiseren van GitOps binnen Kubernetes hebben we verschillende tools overwogen, waaronder Argo CD, vanwege de naadloze integratie met Kubernetes en de ondersteuning voor declaratieve configuraties.


## Beslissing

We hebben besloten om Argo CD te integreren als de tool voor GitOps-implementatie binnen ons Kubernetes-ecosysteem. De redenen voor deze keuze zijn onder andere de automatische synchronisatie met onze Git-repository, eenvoudige UI, en de mogelijkheid om gedetailleerde configuratieaudits uit te voeren. Dit stelt ons in staat om wijzigingen efficiënt en veilig te beheren en door te voeren.

### Alternatieven

- **Flux CD**: Een ander veelgebruikt GitOps-alternatief is Flux CD, dat bekendstaat om zijn lichtgewicht implementatie. Echter, Argo CD biedt betere visualisatie van de status van onze applicaties, wat een prioriteit voor ons project is. Flux CD blijft een optie mocht er behoefte zijn aan een lichtere, command-line gestuurde GitOps-tool.

- **Jenkins Pipeline voor GitOps**: Hoewel Jenkins ook kan worden geconfigureerd voor GitOps door middel van pipelines, zou dit een verhoogde complexiteit met zich meebrengen in termen van configuratie en onderhoud. Argo CD sluit beter aan bij onze behoefte aan een dedicated GitOps-tool met een ingebouwde GUI.

### Consequenties

**Voordelen**:
- **Efficiënte GitOps**: Argo CD stelt ons in staat om GitOps op een intuïtieve en gebruiksvriendelijke manier te implementeren, wat het beheer en onderhoud van onze Kubernetes-configuraties vereenvoudigt.
- **Audit en Rollback**: Dankzij de ingebouwde auditlog en rollback-functionaliteiten in Argo CD kunnen we sneller en veiliger reageren op foutieve configuratiewijzigingen.
- **Minder handmatig werk**: Met Argo CD kunnen wij Git gebruiken als de enige bron van waarheid en de deployments volledig automatiseren.

**Nadelen**:
- **Additionele complexiteit**: Het toevoegen van een extra tool zoals Argo CD kan leiden tot een complexere infrastructuur.
- **Afhankelijkheid van Git**: Omdat Argo CD Git als enige bron gebruikt, kunnen we afhankelijk worden van een constante en veilige Git-toegang.

# Bronnen
- [Argo CD Blog](https://github.com/hanaim-devops/devops-blog-luuk-lentjes/blob/main/src/dev-blog-argo-cd-binnen-gitops-processen-en-kubernetes/README.md)
- [Flux CD Documentation](https://fluxcd.io/docs/)
- [Jenkins Documentation](https://www.jenkins.io/doc/)
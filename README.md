# BiologicalSamplesTraceabilityAPI

# PT-BR
> **Note:** English version bellow.
> 
> Em desenvolvimento

## Descrição

Está é uma API dedicada ao rastreamento de amostras biológicas em lotes.
Partindo de uma proposta, de minha autoria , de melhoria para a gerência de uma determinada empresa pela qual trabalho.
Sugeri uma melhora no rastreamento interno do tempo em que as amostras biológicas levam desde que chegam à unidade até a saída do setor de triagem. 

## Objetivos

- Diminuição de preenchimento manual de planilhas e documentos.
- Diminuição de erros de preenchimento.
- Acompanhamento em tempo real dos dados sem a necessidade de buscar um cadastro de amostra específico.
- Estatísticas para aferição de desempenho
- Analises de gargalos operacionais.

## Pressuposto

 - Essa API tem sua modelagem de dados voltada para a rastreabilidade.   
   
 -  A aplicação esperada é que seja utilizada em rotinas em que as
   amostras biológicas chegam de rotas definidas, como em um laboratório
   de apoio.
> Por exemplo:  um conjunto de amostras da rota do Rio de Janeiro.

   - As amostram chegam ao laboratório de análises clínicas para separação, no pré-analítico.
   - Na concepção da aplicação das regras de negócio, as amostras são agrupadas por rotas ou conjunto de rotas (**Route** ou **RouteGroups**) que chegam de um mesmo motorista (**Driver**).
   - As amostras então são separadas em **cubas, ou bandejas**(**Trays**), e encaminhadas ao fluxo definido no pré-analítico.
   - Os pontos cruciais das etapas de processamento pré-analítico são os **checkpoints**.
   - O fluxo que as amostras irão tomar são as rotinas/**routines** e essas definem quais checkpoints serão registrados.
   - As amostras biológicas variam em características como Acondicionamento (**conditioningType**) e tipo (**SampleType**).
   - Para fins de rastreabilidade e estatísticas dados são necessários como temperatura (**Temperature**), tempo estimado de chegada(**EstArrive**) e etc.
   - O conjunto de amostras é cadastrado com os dados e armazenados em banco de dados.
   - Para identificar um conjunto de amostras, as informações salvas são atrelados a um identificador (**BatchIdentifier**), que por sua vez  é gerado utilizando um identificador único, pelo qual poderá ser consultado e feito o acompanhamento de histórico. 
   - Na rotina de análises clínicas é comum a presença de leitores de códigos de barras e impressoras térmicas. Então são gerados códigos de barras com o código do identificador, para acompanhamento das amostras. 

## Tecnologias 

- C#
- ASP .NET Core
- SQL Server
- Entity Framework
- APIs externas  para geração de código de barras, dashboards e integração com BI.
- Front-end: A definir 

## Desenvolvimento
O primeiro momento é a elaboração de um escopo MVP, a ser expandido futuramente com novas funcionalidades. 

 - [x] Modelagem de dados ([Google Sheet aqui!](https://docs.google.com/spreadsheets/d/1_5k3hydLOWG2Io7Tm9isxcs-6HaDOf1lEl5GByegKW0/edit?usp=sharing))
 - [x] Chore da aplicação ASP .NET Core
 - [x] Criação das Models
 - [x]    Setup do Banco de dados e relacionamentos
 - [ ] Factory e Seeders para testes
 - [ ] Criação de CRUD básico
 - [ ] Adição de endpoints e controllers específicos para manipulação de dados e estatísticas
 - [ ] Testes para validação dos métodos 
 - [ ] Deploy da primeira fase (MVP)
# EN
> In development

## Description

This is an API dedicated to tracking biological samples in batches.
I proposed an improvement to the management of a particular company I work for.
I suggested an improvement in the internal tracking of the time that biological samples take from arriving at the unit to leaving the sorting sector. 

## Objectives

- Reduction in manual completion of spreadsheets and documents.
- Reduction in filling errors.
- Real-time monitoring of data without the need to search for a specific sample record.
- Statistics for benchmarking
- Analysis of operational bottlenecks.

## Assumption

 - This API's data modeling is geared towards traceability.   
   
 - The application is expected to be used in routines where biological
   biological samples arrive from defined routes, such as in a support laboratory.
> For example: a set of samples from the Rio de Janeiro route.

   - The samples arrive at the clinical analysis laboratory for pre-analytical separation.
   - In the design of the business rules application, the samples are grouped by route or set of routes (**Route** or **RouteGroups**) arriving from the same driver (**Driver**).
   - The samples are then separated into **cubes, or trays** (**Trays**), and sent to the flow defined in the pre-analytical process.
   - The crucial points of the pre-analytical processing steps are the **checkpoints**.
   - The flow that the samples will take are the routines and these define which checkpoints will be recorded.
   - Biological samples vary in characteristics such as **conditioningType** and **SampleType**.
   - For traceability and statistical purposes, data is required such as temperature (**Temperature**), estimated time of arrival (**EstArrive**) and so on.
   - The sample set is registered with the data and stored in a database.
   - To identify a set of samples, the information saved is linked to an identifier (**BatchIdentifier**), which in turn is generated using a unique identifier, by which it can be consulted and its history tracked. 
   - In routine clinical analysis, barcode readers and thermal printers are common. Barcodes are then generated with the identifier code to keep track of the samples. 

## Technologies 

- C#
- ASP .NET Core
- SQL Server
- Entity Framework
- External APIs for barcode generation, dashboards and BI integration.
- Front-end: To be defined 

## Development
The first step is to develop an MVP scope, to be expanded in the future with new features. 

 - [x] Data modeling ([Google Sheet here!](https://docs.google.com/spreadsheets/d/1_5k3hydLOWG2Io7Tm9isxcs-6HaDOf1lEl5GByegKW0/edit?usp=sharing))
 - [x] Chore of the ASP .NET Core application
 - [x] Creation of Models
 - [x] Database setup and relationships
 - [ ] Factory and Seeders for testing
 - [ ] Creation of basic CRUD
 - [ ] Adding specific endpoints and controllers for handling data and statistics
 - [ ] Tests to validate methods 
 - [ ] Deploy first phase (MVP)

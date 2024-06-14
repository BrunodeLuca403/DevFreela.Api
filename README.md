<h1>DevFreela</h1>
<p>O projeto foi construído durante um curso visando aperfeiçoar minhas habilidades.</p>

<h3>Descrição</h3>
<p>Plataforma para cadastro e contratação de serviços de Freelancer.</p>

<h3>tecnologias</h3>
<ul>
    <li>.NET 6.0</li>
    <li>Entity Framework Core</li>
    <li>Fluent Validator</li>
    <li>CQRS/MediatorR</li>
    <li>RabbitMQ</li>
</ul>

<h3>Regras de negócio</h3>
<ul>
    <li>Um projeto não pode ser iniciado caso já tenha sido finalizado;</li>
    <li>Um projeto não pode ser finalizado caso já tenha sido iniciado;</li>
    <li>Ao criar um projeto, o título e a descrição são obrigatórios;</li>
    <li>O usuário é obrigado a informar pelo menos uma habilidade ao se cadastrar;</li>
    <li>O email deve ser único para cada usuário na plataforma;</li>
    <li>Um usuário pode ser tanto cliente quanto freelancer, mas não pode ser ambos em um mesmo projeto.</li>
</ul>

<h3>Conceitos aplicados</h3>
<ul>
    <li>Utilização de Docker para gerenciar os serviços e os bancos de dados;</li>
    <li>Documentação de APIs com Swagger;</li>
    <li>Arquitetura em camadas seguindo os princípios da arquitetura limpa;</li>
    <li>Utilização de ORM EfCore nas entidades;</li>
    <li>Implementação do padrão CQRS no projeto;</li>
    <li>Implementação do padrão Repository nas entidades do projeto;</li>
    <li>Validação de APIs com middleware global na camada Application;</li>
    <li>Autenticação com JWT;</li>
    <li>Criação de função para geração de token JWT;</li>
    <li>Geração de migrations com dados de login;</li>
    <li>Armazenamento seguro de senhas utilizando SHA256 no banco de dados (incluindo a role);</li>
    <li>Implementação de login nos serviços;</li>
    <li>Configuração de permissões por recurso e por papel;</li>
    <li>Testes unitários com NSubstitute:</li>
    <ul>
        <li>Entendimento de Mocks e correspondência de argumentos;</li>
        <li>Criação de dois testes utilizando NSubstitute.</li>
    </ul>
    <li>Criação de um serviço de pagamento para o serviço de projetos;</li>
    <li>Abstração de pagamentos no serviço de projetos;</li>
    <li>Conexão entre o serviço de projetos e pagamentos via HTTP;</li>
    <li>Criação de um repositório para salvar os pagamentos em um banco de dados MySQL;</li>
    <li>Conexão entre o serviço de projetos e pagamentos via mensagens (RabbitMQ);</li>
    <li>No serviço de projetos, conexão com filas RabbitMQ e publicação de mensagem de pagamento ao finalizar projeto;</li>
    <li>No serviço de pagamentos, criação de um background service para consumir mensagens de pagamento;</li>
    <li>Tratamento de sucesso e falha nos pagamentos, com envio de mensagens para filas específicas;</li>
    <li>No serviço de projetos, consumo das mensagens das filas de pagamentos aprovados e reprovados, com alterações correspondentes nos projetos.</li>
</ul>

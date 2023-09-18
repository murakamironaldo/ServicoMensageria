# Projeto 
TODO: Projeto de envio de e-mails (serviço de mensageria)


# Getting Started
TODO: Guia:
1.	Processo de instalação
	1. Criação de tabela
		CREATE TABLE `Configuracoes` (
					 `Variavel` varchar(50) NOT NULL,
					 `Valor` varchar(500) NOT NULL,
					 `FlgStatus` int NOT NULL DEFAULT '1',
				PRIMARY KEY (`Variavel`,`Valor`,`FlgStatus`)) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


		CREATE TABLE `tbMensageria` (
					 `codMensageria` int NOT NULL AUTO_INCREMENT,
					 `codCase` int DEFAULT NULL,
					 `codOrigem` int NOT NULL,
					 `origem` varchar(244) NOT NULL,
					 `codDestino` int NOT NULL,
					 `destino` varchar(244) NOT NULL,
					 `titulo` varchar(245) NOT NULL,
					 `msg` text NOT NULL,
				     `flg` int NOT NULL,
					 `dtInsert` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
					 `codUserInsert` int NOT NULL,
					 `dtUpdate` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
					 `codUserUpdate` int NOT NULL,
				PRIMARY KEY (`codMensageria`)) ENGINE=InnoDB AUTO_INCREMENT=454 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


	2.	Inserir registros de configuração
		INSERT INTO `Configuracoes` (`Variavel`,`Valor`,`FlgStatus`,`Descricao`) VALUES ('smtp.host','',1,'Host do Smtp');
		
        INSERT INTO `Configuracoes` (`Variavel`,`Valor`,`FlgStatus`,`Descricao`) VALUES ('smtp.porta','',1,'Porta do smtp');	
		 
        INSERT INTO `Configuracoes` (`Variavel`,`Valor`,`FlgStatus`,`Descricao`) VALUES ('smtp.quantidadeemails','',1,'Quantidade de envio de e-mails');
		 
        INSERT INTO `Configuracoes` (`Variavel`,`Valor`,`FlgStatus`,`Descricao`) VALUES ('smtp.remetente.email','',1,'Email do remetente');
		 
        INSERT INTO `Configuracoes` (`Variavel`,`Valor`,`FlgStatus`,`Descricao`) VALUES ('smtp.remetente.nome','',1,'Nome do Remetente');
		 
        INSERT INTO `Configuracoes` (`Variavel`,`Valor`,`FlgStatus`,`Descricao`) VALUES ('smtp.senha','',1,'Senha do Smtp');
		 
        INSERT INTO `Configuracoes` (`Variavel`,`Valor`,`FlgStatus`,`Descricao`) VALUES ('smtp.ssl','FALSE',1,'Possui ssl? ');
		 
        INSERT INTO `Configuracoes` (`Variavel`,`Valor`,`FlgStatus`,`Descricao`) VALUES ('smtp.tempoenvio','30',1,'Tempo em minutos');
		 
		
		*** O tempo de envio é em minutos



# Pacotes importantes
- Framework .net core 7;
- Banco de dados: mysql

# Contribute
TODO: Explain how other users and developers can contribute to make your code better. 

If you want to learn more about creating good readme files then refer the following [guidelines](https://docs.microsoft.com/en-us/azure/devops/repos/git/create-a-readme?view=azure-devops). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)
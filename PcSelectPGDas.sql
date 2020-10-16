Declare @CodEmpresa int = 156, @DataInicialP datetime = '2018-12-01', @DataFinalP datetime = '2018-12-31'

Select 
(
	Select C.Cnpj,
	C.CPFRespTecnico,
	C.CodigoAcessoSimples,
	Concat(DatePart(year, @DataInicialP), '/', DatePart(month, @DataInicialP)) PA,
	S.FaturamentoAnualMercadoInterno FaturamentoMercadoInterno,
	S.FaturamentoAnualMercadoExterno FaturamentoMercadoExterno
	For Xml Path(''), Elements, Root('DadosPgDas'), Type  
)
From CadEmpresa C
Join ControleServicos Cs on (Cs.CodEmpresa = C.CodEmpresa)
Join RegApSimplesNacional S on (S.FkControleServicos = Cs.Pk)
Where (C.CodEmpresa = @CodEmpresa) and
(Cs.DataInicial = @DataInicialP) and
(Cs.DataFinal = @DataFinalP)


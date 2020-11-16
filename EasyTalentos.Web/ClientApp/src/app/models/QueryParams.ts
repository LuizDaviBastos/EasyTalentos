
class Paginacao {

  public pagina: number = 1;
  public tamanhoPagina: number = 10;
  public totalRegistro: number = 1;

}

export class QueryParams extends Paginacao  {

  public pesquisa: string = "";

}



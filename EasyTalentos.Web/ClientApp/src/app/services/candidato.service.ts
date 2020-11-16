import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { Candidato } from '../models/Candidato';
import { QueryParams } from '../models/QueryParams';



@Injectable({
  providedIn:'root'
})
export class CandidatoService {

  private get _httpHeaders() {

    return new HttpHeaders().set('content-type', 'application/json');
  }

  //Antes do retorno verifica o ambiente para retornar a url correta.
  get baseUrl() {
    return environment.api;
    //else return this._baseUrl;
  }
  

  constructor(private http: HttpClient, @Inject('BASE_URL') private _baseUrl: string) { }


  public obterCandidatos(queryParams: QueryParams): Observable<any> {

    var params = new HttpParams()
      .set('pagina', queryParams.pagina.toString())
      .set('pesquisa', queryParams.pesquisa)
      .set('tamanhoPagina', queryParams.tamanhoPagina.toString())
      .set('totalRegistro', queryParams.totalRegistro.toString());


    return this.http.get(`${this.baseUrl}api/candidato/obter`, { headers: this._httpHeaders,  params });
  }

  public cadastrarCandidato(candidato: Candidato): Observable<any> {

    return this.http.post(`${this.baseUrl}api/candidato/cadastrar`, candidato, { headers: this._httpHeaders })
  }

  public atualizarCandidato(candidato: Candidato): Observable<Candidato> {

    return this.http.put<Candidato>(`${this.baseUrl}api/candidato/atualizar`, candidato, { headers: this._httpHeaders });
  }

  public excluirCandidato(id: number): Observable<any> {
    var params = new HttpParams().set('id', id.toString());

    return this.http.delete(`${this.baseUrl}api/candidato/excluir`, { params });
  }
    
}

import { Component, OnInit } from '@angular/core';
import { Candidato } from '../models/Candidato';
import { QueryParams } from '../models/QueryParams';
import { CandidatoService } from '../services/candidato.service';

@Component({
  selector: 'app-gerenciar-candidatos',
  templateUrl: './gerenciar-candidatos.component.html'
})

export class GerenciarCandidatosComponent implements OnInit {

  public candidatos: Candidato[];
  public candidatoEdit: Candidato;
  public queryParams: QueryParams;

  public mensagemAlert: string;

  public open: boolean = false;

  constructor(private candidatoService: CandidatoService) { }

  ngOnInit(): void {
    this.queryParams = new QueryParams();
    this.queryParams.tamanhoPagina = 10;

    this.candidatoEdit = new Candidato();
    this.obterCandidatos();
  }

  public obterCandidatos(pagina = 1, pesquisa: string = "") {
    this.queryParams.pagina = pagina;
    this.queryParams.pesquisa = pesquisa;
    this.candidatoService.obterCandidatos(this.queryParams).subscribe(
      result => {
        console.log(result);
        this.queryParams = result.queryParams;
        this.candidatos = result.candidatos;
      },
      error => {
        console.log(error.error);
      });
  }

  public editarCandidato(candidato: Candidato) {
    this.candidatoService.atualizarCandidato(candidato).subscribe(
      result => {

        alert("sucesso");
        console.log(result);

        //atualizando elemento na lista local
        var indice = this.candidatos.indexOf(this.candidatos.find(c => c.id == candidato.id));
        this.candidatos[indice] = result as Candidato;

      },
      error => {
        alert("erro");
        console.log(error.error);
      }
    );
  }

  public excluirCandidato(id: number) {

    if (window.confirm("tem certeza?")) {
      
      this.candidatoService.excluirCandidato(id).subscribe(
        result => {

          this.candidatos = this.candidatos.filter(c => c.id != id);

          alert("Registro excluido");
          
        },
        error => {
          alert("Erro ao excluir registro")
          console.log(error.error);
        }
      );
    }
  }


  public openModal(cand: Candidato) {
    this.open = true;
    this.candidatoEdit = Object.assign({}, cand);;
  }

  public closeModal() {
    this.open = false;
    this.candidatoEdit = new Candidato();
  }

}

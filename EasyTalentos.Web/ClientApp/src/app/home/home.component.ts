import { Component, OnInit } from '@angular/core';
import { Candidato } from '../models/Candidato';
import { CandidatoService } from '../services/candidato.service';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {

  public candidato: Candidato;


  constructor(private candidatoServico: CandidatoService) {

  }

  ngOnInit(): void {

    this.candidato = new Candidato();

  }

  public cadastrar(candidato: Candidato) {


    this.candidatoServico.cadastrarCandidato(candidato).subscribe(
      result => {
        console.log("sucesso");
        alert("sucesso");

        this.candidato = new Candidato();
        

      },
      error => {
        alert("erro");
        console.log(error.error);
      });

    
    //Cadastrar candidato ao banco usando servico
    //console.log(JSON.stringify(candidato));

  }



}

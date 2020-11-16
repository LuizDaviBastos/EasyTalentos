import { Component, OnInit, Input, Output, EventEmitter, AfterViewInit, TemplateRef, ContentChild } from '@angular/core';
import { Candidato } from '../../models/Candidato';
import { Conhecimento } from '../../models/Conhecimento';


@Component({
  selector: 'form-candidato',
  templateUrl: './form-candidato.component.html'
})
export class FormCandidatoComponent implements OnInit, AfterViewInit {

  public properties: string[] =
  new Conhecimento().getProperties().filter(x => x != "outras" && x != "linkCrud");

  public candidato: Candidato;

  public candidatoContexto: | 'SEND' | 'EDIT' | 'ADD';

  public Send: boolean = false;
  public Add: boolean = false;
  public Edit: boolean = false;


  @Input('text-submit')
  set inputTextSubmit(candidatoContexto: | 'SEND' | 'EDIT' | 'ADD') {
    this.candidatoContexto = candidatoContexto;
  }

  @Input('candidato')
  set inputCandidato(candidato: Candidato) {
    //this.candidato = Object.create(candidato);
    this.candidato = candidato;

    //this.candidato = candidato;

  }

  @Output('submit') submitEvento: EventEmitter<any> = new EventEmitter();


  constructor() {

  }
  ngAfterViewInit(): void {

  }

  ngOnInit(): void {
    //this.candidato = new Candidato();

  }


  public submit() {
    //console.log(this.candidato);
    this.submitEvento.emit (this.candidato);
    //this.submitEvento.emit();
  }


}


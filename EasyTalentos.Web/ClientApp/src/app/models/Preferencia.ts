import { Candidato } from "./Candidato";

export class Preferencia {
  id: number;
  manha: boolean = false;
  tarde: boolean = false;
  noite: boolean = false;
  madrugada: boolean = false;
  comercial: boolean = false;
  candidatoId: number;
  candidato: Candidato;
}

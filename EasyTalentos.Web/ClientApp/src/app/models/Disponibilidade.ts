import { Candidato } from "./Candidato";

export class Disponibilidade {
  id: number;
  ateQuatro: boolean = false;
  quatroAteSeis: boolean = false;
  seisAteOito: boolean = false;
  acimaDeOito: boolean = false;
  finaisDeSemana: boolean = false;
  candidatoId: number;
  candidato: Candidato;
}

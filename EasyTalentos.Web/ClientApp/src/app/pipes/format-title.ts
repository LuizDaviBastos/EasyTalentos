import { Pipe, PipeTransform } from "@angular/core";

@Pipe({
  name : 'titulo'
})
export class FormatTitlePipe implements PipeTransform {

  transform(value: string): string {
    let newValue: string = "";

    for (var i = 0; i < value.length; i++) {

      if (this.isUpperCase(value[i])) {
        newValue += ` ${value[i]}`;
      }
      else {
        newValue += value[i];
      }
      
    }

    return newValue;

  }

  isUpperCase(value :string ): boolean {
    let backup = value;
    return backup == value.toUpperCase()
  }
  
}

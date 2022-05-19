import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-credit-card',
  templateUrl: './credit-card.component.html',
  styleUrls: ['./credit-card.component.css']
})
export class CreditCardComponent implements OnInit {

  listTarjetas : any[] =[
    { Nombre:"Pedro Aveiro", numeroTarjeta:"123456789", fechaExp: "11/27", cvv:123},
    { Nombre:"Pedro Aveiro", numeroTarjeta:"123456789", fechaExp: "11/27", cvv:456},
    { Nombre:"Pedro Aveiro", numeroTarjeta:"123456789", fechaExp: "11/27", cvv:789}
  ]

  form: FormGroup;

  constructor(private formBuilder: FormBuilder, private toastr: ToastrService) {
    this.form = this.formBuilder.group({
      Nombre:['',  [Validators.required, Validators.minLength(10), Validators.maxLength(20)]],
      numeroTarjeta:['', [Validators.required, Validators.minLength(16), Validators.maxLength(16)]],
      fechaExp:['' , [Validators.required, Validators.minLength(1)]],
      cvv:['', [Validators.required, Validators.min(1), Validators.max(999)]]
    })
   }

  ngOnInit(): void {
  }

  SendData(){

    let tarjeta : any = {
      Nombre: this.form.value["Nombre"],
      numeroTarjeta: this.form.value["numeroTarjeta"],
      fechaExp: this.form.value["fechaExp"],
      cvv: this.form.value["cvv"] 
    }

    this.toastr.success('Hello world!', 'Toastr fun!');

  }

}

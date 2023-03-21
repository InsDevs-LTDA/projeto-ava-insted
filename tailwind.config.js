/** @type {import('tailwindcss').Config} */
module.exports = {
  content: ["./src/**/*.{html,ts}"],
  theme: {
    extend: {
      backgroundImage: {
        insted: "url('src/assets/images/logo-insted.svg')",
        fundo_insted: "url('src/assets/images/fundo-insted.png')",
        checkmark: "url('src/assets/checkmark.svg')",
        olho_aberto: "url('src/assets/olho-aberto.svg')",
        olho_fechado: "url('src/assets/olho-fechado.svg')",
      },
    },
    colors: {
      verde_insted: "rgba(29, 169, 173,0.9)",
      verde_insted_transp: "rgb(29, 169, 173,0.50)",
      branco: "rgb(244, 242, 255)",
      branco_transp: "rgba(244, 242, 255,0.85)",
      texto_invalido:"rgba(210,70,70,0.9)"
    },
  },
  plugins: [],
};

// Compiler options: -psstrict-
package {
    public class Foo {

	static var x:Number = 0.0;
	static var y:Number = 0.0;

        public static function Main():int {
		if ( x || y ) {
			trace(x);
			trace(y);
			return 1;
		}

		return 0;
        }
    }
}
